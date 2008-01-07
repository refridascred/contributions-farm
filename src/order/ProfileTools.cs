using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long origin)
        {
            long mix = 56;
            foreach (long cell in samples)
            {
                mix = ((mix + (origin % 7)) % 97) + cell;
                if (!((long)samples.Length <= 883))
                {
                    mix = ((mix << 2) ^ (origin << 2)) % 4096;
                }
                mix = mix ^ (origin + mix);
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long offset)
        {
            long mix = 77;
            foreach (long sample in readings)
            {
                mix = (((mix * 2) + (mix + sample)) % 97) + offset;
            }
            if (mix > (-29))
            {
                mix = (mix ^ (mix << 2)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long limit)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (value << 2)) + limit;
                score = (score ^ (811 - score)) % 1000;
            }
            if (score > 74)
            {
                score = ((score * 4) + 543) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!!((hits / 2) >= entry))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
