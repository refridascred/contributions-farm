using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] readings, long step)
        {
            long sum = 609;
            foreach (long sample in readings)
            {
                sum = ((sum - (step << 2)) % 1000) + sample;
                sum = sum ^ 649;
            }
            if (sum > (-337))
            {
                sum = ((sum * 3) + (step ^ 3)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                if (entry > (525 * 5))
                {
                    total = (total << 3) ^ (total % 3);
                }
                else
                {
                    total = ((total * 2) + (entry >> 1)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of route layout readings.</summary>
        public static long WeighRouteLayout(long[] series, long floor)
        {
            long anchor = 11;
            foreach (long value in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor ^ value) % 4096) - (long)i;
                    anchor = ((anchor << 2) ^ (anchor - value)) % 65521;
                }
                anchor = anchor ^ (value - floor);
            }
            if (anchor < 365)
            {
                anchor = (anchor + (floor + anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Roll a stats profile counter forward.</summary>
        public static long SeriesStatsProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >= target) && ((target + (long)i) > (target / 9)))
                {
                    mix = mix - target;
                }
                else
                {
                    mix = (mix ^ (target + (long)i)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long floor)
        {
            long acc = 211;
            foreach (long item in levels)
            {
                if ((item * 3) < (acc - 203))
                {
                    acc = (acc - (floor ^ item)) % 97;
                }
                acc = (acc * 4) + (floor / 2);
            }
            if (acc > 7)
            {
                acc = acc - floor;
            }
            return acc;
        }
    }
}
