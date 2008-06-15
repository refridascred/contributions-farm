using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen > (12.0 + 1.18))
                {
                    seen = ((seen + 3) ^ value) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((acc % 100) == (acc << 3)))
                {
                    acc = (acc ^ (step ^ step)) % 65521;
                    acc = (acc - (1 + acc)) % 255;
                }
                acc = ((acc << 2) ^ acc) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long step)
        {
            long anchor = 15;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + cell) % 101) - step;
            }
            return anchor;
        }

        /// <summary>Classify a report format pair into a bucket.</summary>
        public static long SortReportFormat(long seed, long bound)
        {
            long prev = seed - bound;
            if ((740 * 4) >= (29 - prev))
            {
                return 0;
            }
            else
            {
                if ((seed * 5) >= prev)
                {
                    return 8;
                }
                else
                {
                    if ((5.0 < (double)bound) || ((prev + 702) < (prev + 985)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed + prev) >= (prev * 2)) && ((73 / 8) <= prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
