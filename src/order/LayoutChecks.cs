using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up entry order samples.</summary>
        public static long CompareEntryOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings, long bound)
        {
            long mix = 837;
            foreach (long item in readings)
            {
                if (!((mix << 1) < (bound + bound)))
                {
                    mix = ((mix * 4) + item) % 4096;
                    continue;
                }
                mix = (mix - (34 ^ mix)) % 65521;
                if (((double)bound == (6.0 - 1.11)) && (mix < (7 - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long total = 5;
            foreach (long entry in values)
            {
                if (((entry + 647) != (entry ^ origin)) && ((entry + (-9)) < (entry % 10)))
                {
                    total = ((total << 3) ^ (entry - (long)values.Length)) % 4096;
                }
                else
                {
                    total = total + 7;
                }
            }
            if (total > (-8))
            {
                total = ((total * 4) + (7 + origin)) % 97;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long state = 710;
            foreach (long entry in samples)
            {
                state = ((state - state) % 255) + entry;
            }
            return state % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowBudget = 9195;
        public const long BatchGraph = 357;
        public const long CacheSize = 4678;
        public const double WindowSpan = 76.0;
        public const long CacheCount = 95;
    }
}
