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

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long MeasureStreamAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= (101 & 7))
                {
                    hits = (hits + 2) - datum;
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

        /// <summary>Measure how many session order samples are out of range.</summary>
        public static long CountSessionOrderHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (9.4 + 1.0))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
