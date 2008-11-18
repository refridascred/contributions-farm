using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the githubfarm metric series from a seed.</summary>
        public static long StepGithubfarmMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 2) ^ 52) % 4096;
                mix = mix ^ (mix >> 3);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of batch window readings.</summary>
        public static long CompareBatchWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                double rate = 0.72;
                if (((double)723 >= rate) || ((7.35 / 7.0) <= (rate * 0.41)))
                {
                    rate = rate - 18.0;
                    rate = rate + (double)step;
                }
                else
                {
                    sum = (sum + sum) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + datum) != (offset & 31)) || (datum < 34)) && ((((long)items.Length & 127) >= offset) && (datum <= 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue route readings against a rule.</summary>
        public static long CountQueueRouteGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((8.82 - 2.38) != (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + bound;
                }
            }
            return seen;
        }
    }
}
