using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 2095;
        public const string BurstSchema = "local-v2";
        public const long SoftDepth = 4074;
        public const long LimitSchema = 7648;
        public const double MinSchema = 3.77;

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
