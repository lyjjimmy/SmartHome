using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class RandomSensorGenerator
    {
        private enum SensorTypes { HEART_RATE, BLOOD_PRESSURE, TEMPERATURE, FAIL_STATUS, GPS };
        private Sensor sensor;
        private Random randomNumberGenerator;

        public RandomSensorGenerator(Sensor sensor)
        {
            this.sensor = sensor;
        }

        public string returnData()
        {
            string returnedValue = "";
            int outint;
            double outdouble;

            switch (sensor.SensorType)
            {
                case (int)SensorTypes.HEART_RATE:
                    Console.WriteLine("Monitoring Heart Rate");
                    // Simulate the heart rate data once
                    if (int.TryParse(sensor.SensorData, out outint))
                    {
                        returnedValue = generateHeartRateData(int.Parse(sensor.SensorData)).ToString();
                    }
                 
                    break;

                case (int)SensorTypes.BLOOD_PRESSURE:
                    Console.WriteLine("Monitoring Blood Pressure");
                    // Simulate the blood pressure data once
                    if (int.TryParse(sensor.SensorData, out outint))
                    {
                        returnedValue = generateBloodPressure(int.Parse(sensor.SensorData)).ToString();
                    }

                    break;

                case (int)SensorTypes.TEMPERATURE:
                    Console.WriteLine("Monitoring Body Temperature");
                    // Simulate the body temperature data once
                    if (double.TryParse(sensor.SensorData, out outdouble))
                    {
                        returnedValue = generateBodyTemperature(double.Parse(sensor.SensorData)).ToString();
                    }

                    break;

                case (int)SensorTypes.FAIL_STATUS:
                    Console.WriteLine("Monitoring falling status");
                    bool outbool;
                    // Simulate the falling status data once
                    if (bool.TryParse(sensor.SensorData, out outbool))
                    {
                        returnedValue = generateFallStatus(bool.Parse(sensor.SensorData)).ToString();
                    }

                    break;

                case (int)SensorTypes.GPS:
                    break;
                default:
                    break;
            }

            return returnedValue;
        }


        /* Generator for Heart Rate data
         * 
         * Descriptions: 
         * This portion of code will simulate the heart rate number continuously
         * Normal range: [50,100]   Danger range (should issue alarm): [0,30] [>120]
         * Machanisum to generate the data
         * 1) Generate a based data at the vedry begining (starting from range [30,120] )
         * 2) Generate a much smaller amount of increment or decrement amount (from [0,5])
         * 3) If (previous + difference) % 2 == 0, goes positive, otherwise goes negative
         */
        private int generateHeartRateData(int previousFigure)
        {
            if (previousFigure < 0) // no precious reading
            {
                return randomNumberGenerator.Next(30, 120);
            }
            else
            {
                int nextDifference = randomNumberGenerator.Next(0, 5);
                if ((previousFigure + nextDifference) % 2 == 0)
                {
                    return previousFigure + nextDifference;
                }
                else
                {
                    return previousFigure - nextDifference;
                }
            }
        }
        
        /* Generator for Blood Pressure Data
         * 
         * Description:
         * This portion of code will generate one random blood pressure data.
         * Systolic pressure ONLY
         * Normal range: [90, 140], Danger range: [<80], [>150]
         * Starting point: [85,145]
         * Same methodology to generate the data
         */
        private int generateBloodPressure(int previousFigure)
        {
            if (previousFigure < 0) // no previous reading
            {
                return randomNumberGenerator.Next(90, 140);
            }
            else
            {
                int differences = randomNumberGenerator.Next(0, 4);
                if ((previousFigure + differences) % 2 == 0)
                {
                    return previousFigure + differences;
                }
                else
                {
                    return previousFigure - differences;
                }

            }
        }

        /*
         * Generator for Body Temperature Data
         * 
         * Description:
         * This portion of code will generate one random body temperature data
         * Normal Range: [36.5, 37.5], Danger range: [<36] [>38]
         * Starting point: [36, 38]
         * Similar method to generate data, but using Random.NextDouble to generate the differences
         */
        private double generateBodyTemperature(double previousReading)
        {
            if (previousReading < 0) // no previous reading
            {
                return randomNumberGenerator.Next(360, 380) / 10;
            }
            else
            {
                double differences = randomNumberGenerator.NextDouble();
                if ((previousReading + differences) * 10 % 2 == 0)
                {
                    return previousReading + differences;
                }
                else
                {
                    return previousReading - differences;
                }
            }
        }

        /* Genrator for falling status data
         * 
         * Description:
         * this portion of code will generate one random falling boolean status data
         * Normal status: false, Danger status: true
         * Starting point: none
         * method to generate status
         * 1) generate a random number from 0 to 499 (a total of 500)
         * 2) if the generated number is 0, it means fall, otherwise not
         * 3) if the previous records is fall, the generated range will be 0 to 1 (a total of 2)
         *    as falling status may continue
         */
        private bool generateFallStatus(bool previousStatus)
        {
            int randomNumber;
            if (previousStatus == true) // if fall already
            {
                randomNumber = randomNumberGenerator.Next(0, 1);
            }
            else // not fall previously or no previous status
            {
                randomNumber = randomNumberGenerator.Next(0, 499);
            }
            if (randomNumber == 0) // status of fall
            {
                return true;
            }
            else // status of not fall
            {
                return false;
            }
        }

        /* Generator for Location data
         * 
         * Generating range - within square area of Sydney
         * range of latitude of sydney  [-33.4, -34.5]
         * range of longitude of sydney [150.5, 151.4]
         * increment range [0.0000001, 0.0000005]
         * smae method to generate the location point 
         */
        private string generateLocationPoint(string previousLocation)
        {
            double latitude = 0;
            double longitude = 0;

            if (previousLocation != "0,0") // has previous location
            {
                double outdouble;
                // Decompose the previousLocation
                string[] values = previousLocation.Split(',');
                if (double.TryParse((string)values.GetValue(0), out outdouble) && double.TryParse((string)values.GetValue(1), out outdouble))
                {
                    latitude = double.Parse((string)values.GetValue(0));
                    longitude = double.Parse((string)values.GetValue(1));
                }
            }

            return "" + latitude + "," + longitude;
        }
    }
}