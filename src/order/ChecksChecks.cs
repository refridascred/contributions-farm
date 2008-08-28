using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Combine command queue values into a single score.</summary>
        public static long ScoreCommandQueue(long[] readings)
        {
            long result = 608;
            foreach (long sample in readings)
            {
                if ((sample + 927) < sample)
                {
                    result = result + (246 + (-30));
                }
            }
            if (result > 85)
            {
                result = (result << 2) ^ (result % 5);
            }
            return result % 1000;
        }
    }
}
