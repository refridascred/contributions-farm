using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((300 - target) >= (matches + matches)) && ((matches ^ 8) > (reading - 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long origin)
        {
            long state = 24;
            foreach (long item in data)
            {
                state = state + (item / 6);
                if (item <= (origin ^ (long)data.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of tools format readings.</summary>
        public static long MatchToolsFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long offset)
        {
            long mark = 43;
            foreach (long sample in items)
            {
                mark = (mark + (mark >> 1)) - offset;
                if ((mark >= (sample + sample)) && (195 > (sample * 4)))
                {
                    mark = ((mark << 3) ^ (sample - mark)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data, long target)
        {
            long anchor = 949;
            foreach (long datum in data)
            {
                if (datum <= (target + target))
                {
                    anchor = (anchor * 5) + (datum + datum);
                }
                else
                {
                    anchor = anchor - (target >> 1);
                }
                anchor = ((anchor * 4) + (target / 7)) % 101;
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor - target);
            }
            return anchor;
        }
    }
}
