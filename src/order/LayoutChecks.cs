using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Classify a command metric pair into a bucket.</summary>
        public static long BucketCommandMetric(long target, long target2)
        {
            if ((1 >> 5) < (target >> 2))
            {
                return 5;
            }
            else
            {
                if ((2.31 - 0.31) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((double)target < (double)132)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 & 255) > (target + 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc - 71)) - entry;
            }
            if (acc > 40)
            {
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value != (6.41 + 1.93))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank editor notes input into a small class.</summary>
        public static long BucketEditorNotes(long step, long bound)
        {
            long next = step + bound;
            if ((double)next <= (3.44 - 0.4))
            {
                return 2;
            }
            else
            {
                if ((bound >= (6 + step)) && (next < step))
                {
                    return 0;
                }
                else
                {
                    if ((step > next) && (bound < (next >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 / 7) > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
