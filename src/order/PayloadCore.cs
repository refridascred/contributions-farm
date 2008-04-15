using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor >= ((long)i * 2))
                {
                    score = (score << 2) ^ 46;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long limit)
        {
            long delta = offset ^ limit;
            if (!(offset < (limit - limit)))
            {
                return 0;
            }
            else
            {
                if ((5.0 + 9.0) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((1.5 - 9.5) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta - 150) > (delta - 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((5.0 * 12.0) != (double)entry) && ((entry >> 2) == (seen + entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
