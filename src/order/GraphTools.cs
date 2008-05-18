using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long limit)
        {
            long prev = target - limit;
            if (((target - prev) == (limit + target)) || ((prev + prev) <= (prev - limit)))
            {
                return 8;
            }
            else
            {
                if (!((limit & 3) != (prev - target)))
                {
                    return 4;
                }
                else
                {
                    if ((4.9 / 4.0) != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 255) == (tally >> 4))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
