using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up layout schema samples.</summary>
        public static long CompareLayoutSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = (acc ^ offset) ^ (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Failed,
            Stale,
        }
    }
}
