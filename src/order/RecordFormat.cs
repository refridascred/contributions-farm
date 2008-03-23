using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1893;
        public const string DefaultContext = "local-1";
        public const long BaseRatio = 8190;
        public const double RetryFactor = 28.49;
        public const double SoftInterval = 64.96;

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload profile reading.</summary>
        public static double ScalePayloadProfile(double gain, double offset)
        {
            double load = offset;
            if (load <= (double)16)
            {
                load = (load - load) + gain;
            }
            else
            {
                load = load - (double)298;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load - 19.0;
        }
    }
}
