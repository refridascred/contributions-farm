using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long bound)
        {
            if (!((step >> 5) > step))
            {
                return 7;
            }
            else
            {
                if ((6.4 * 6.8) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (((double)step > (5.0 + 7.7)) && ((step - bound) >= (step + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) != ((-986) / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long seed)
        {
            long cur = bound ^ seed;
            if ((seed % 16) <= cur)
            {
                return 3;
            }
            else
            {
                if (bound <= (cur - bound))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (cur + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound != (15.0 * 0.73))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
