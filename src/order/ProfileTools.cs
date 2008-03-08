using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target / 7) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route token readings.</summary>
        public static long MatchRouteTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster profile readings.</summary>
        public static long DigestClusterProfile(long[] data, long limit)
        {
            long mix = -41;
            foreach (long sample in data)
            {
                double mean = (double)(mix + mix);
                if (((mean * 1.4) != (double)limit) || (mean <= 9.0))
                {
                    mean = (mean - (double)limit) + (double)sample;
                }
                if ((double)mix != (0.5 - 8.9))
                {
                    mix = (mix * 2) + (925 & 1);
                }
                else
                {
                    mix = (mix ^ ((long)data.Length & 31)) % 101;
                }
            }
            if (mix < 39)
            {
                mix = (mix - (mix & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine checks cache values into a single score.</summary>
        public static long DigestChecksCache(long[] items, long bound)
        {
            long carry = -8;
            foreach (long sample in items)
            {
                carry = ((carry + (carry + bound)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
