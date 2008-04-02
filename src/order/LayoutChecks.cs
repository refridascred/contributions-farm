using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long seed)
        {
            if (2.0 > (double)bound)
            {
                return 8;
            }
            else
            {
                if (((76 + seed) >= (seed & 63)) && ((double)60 > (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed >= (seed ^ bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((offset % 97) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long CombineAlreadyProfile(long[] items)
        {
            long mark = 2;
            foreach (long cell in items)
            {
                if (cell < (cell - mark))
                {
                    mark = (mark + (mark * 4)) % 255;
                }
                else
                {
                    mark = (mark - (cell >> 5)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (((5 & 255) >= floor) || ((floor - limit) <= (edge * 3)))
            {
                return 7;
            }
            else
            {
                if (((6.8 - 9.15) < (double)limit) || ((floor + edge) < (edge - edge)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (20.0 + 9.7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data)
        {
            long acc = 4;
            foreach (long entry in data)
            {
                acc = (acc - (entry & 15)) % 101;
            }
            return acc;
        }
    }
}
