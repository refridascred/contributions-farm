using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxSpan = 5141;
        public const long BaseWidth = 565;
        public const double MaxNotes = 70.88;

        /// <summary>Match up contributi support samples.</summary>
        public static long PairContributiSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long seed)
        {
            long next = step - seed;
            if ((double)next >= (1.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((step * 5) == (seed * 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
