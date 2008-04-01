using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series, long origin)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                if (!((origin * 4) >= (1 ^ entry)))
                {
                    carry = (carry + (origin + carry)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (origin / 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((89 / 8) <= step) || ((seen - step) > step))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm token figure with a bias.</summary>
        public static double ScaleFarmToken(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (scale + scale)) + (double)(long)i) - floor;
            }
            return scale - 13.0;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
