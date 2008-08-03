using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double load = (double)((-625) + 3);
            if (load >= (double)60)
            {
                load = (load - load) - rate;
            }
            else
            {
                load = load + 1.85;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor * 13.0)) + (double)(long)i;
            }
            return load - 7.1;
        }

        /// <summary>Roll a githubfarm batch counter forward.</summary>
        public static long StepGithubfarmBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double load = (double)(9 / 8);
            if (load <= (floor + load))
            {
                load = (load - 3.29) - ratio;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (4.66 / 3.0)) + (double)(long)i;
            }
            return load - (floor - load);
        }
    }
}
