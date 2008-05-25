using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor cache readings.</summary>
        public static long DigestEditorCache(long[] items)
        {
            long total = 86;
            foreach (long reading in items)
            {
                if (((3.0 * 8.14) > (double)total) && ((double)reading != (17.0 + 6.09)))
                {
                    total = (total + (total - reading)) % 65521;
                }
                else
                {
                    total = total - reading;
                }
            }
            if (total < 76)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Derive the next report session value from a seed.</summary>
        public static long StepReportSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
