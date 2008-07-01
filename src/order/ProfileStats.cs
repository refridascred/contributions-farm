using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings, long floor)
        {
            long mark = 353;
            foreach (long datum in readings)
            {
                mark = ((mark * 5) + (983 - datum)) % 97;
                if ((30 + 13) <= (datum >> 1))
                {
                    mark = mark + (floor % 100);
                }
                else
                {
                    mark = mark - (datum - floor);
                }
                if ((mark + floor) != (datum + 8))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
