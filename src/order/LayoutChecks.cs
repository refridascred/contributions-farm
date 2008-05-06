using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(81 > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long anchor = 87;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 2) ^ anchor) % 4096) + target;
                if ((cell > 5) || ((anchor << 2) < (anchor * 2)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)cell <= (9.72 + 3.1)) || ((cell + 90) <= 54))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
