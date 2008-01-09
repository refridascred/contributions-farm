using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long offset)
        {
            long sum = 5;
            foreach (long sample in series)
            {
                if ((sum % 7) > (sample + offset))
                {
                    sum = (sum + (sample - offset)) % 4096;
                }
                else
                {
                    sum = (sum + sample) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchDepth = 9.03;
        public const string SoftChannel = "local-1";
        public const double DefaultChannel = 34.54;
        public const long CacheChannel = 1703;

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items, long offset)
        {
            long mark = 76;
            foreach (long sample in items)
            {
                if (((offset & 3) >= (281 & 7)) && ((double)mark <= (6.08 - 3.3)))
                {
                    mark = (mark + (offset % 3)) % 255;
                    break;
                }
                else
                {
                    mark = mark + ((long)items.Length / 5);
                }
                if (((mark >> 5) < ((long)items.Length % 16)) && ((52 >> 2) > (offset / 2)))
                {
                    mark = mark + (sample << 3);
                }
                else
                {
                    mark = (mark + (offset >> 1)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entry entries.</summary>
        public static long TotalBatchEntry(long[] samples)
        {
            long mix = 65;
            foreach (long value in samples)
            {
                mix = mix - (mix - value);
            }
            if (mix > 6)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Draft,
            Retry,
            Paused,
            Done,
        }
    }
}
