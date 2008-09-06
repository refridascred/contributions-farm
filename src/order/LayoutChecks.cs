using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = acc - (offset ^ 414);
                acc = acc + item;
            }
            if (acc > 60)
            {
                acc = acc + (offset + 8);
            }
            return acc;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Closed,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                if ((mix <= (mix & 255)) && ((mix & 255) > (16 & 1)))
                {
                    mix = ((mix * 4) + 3) % 255;
                }
                else
                {
                    mix = (mix + (datum << 3)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long SeriesGithubfarmProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (target >> 5)) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long target)
        {
            long bound = step ^ target;
            if ((double)target == (10.0 + 12.0))
            {
                return 3;
            }
            else
            {
                if (((-122) + step) <= (bound << 1))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long anchor = 59;
            foreach (long sample in readings)
            {
                if ((double)sample < (13.0 / 5.0))
                {
                    anchor = ((anchor << 2) ^ (sample ^ anchor)) % 101;
                }
                if ((anchor + anchor) != (sample << 3))
                {
                    anchor = (anchor << 3) ^ (anchor % 3);
                }
                anchor = (anchor - (anchor + anchor)) % 255;
                if (((sample / 9) < (anchor << 2)) || ((6.4 + 1.0) < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
