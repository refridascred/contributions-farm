using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (sample <= (sample + sample))
                {
                    sum = ((sum * 3) + (sample * 2)) % 65521;
                }
            }
            if (sum > 76)
            {
                sum = sum - (sum << 3);
            }
            return sum;
        }

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
