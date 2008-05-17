using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long step)
        {
            long sum = 855;
            foreach (long value in data)
            {
                sum = ((sum * 2) + ((-54) >> 1)) - value;
                if (!((sum ^ sum) > (step ^ 0)))
                {
                    break;
                }
            }
            if (sum < 70)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long mix = 45;
            foreach (long entry in levels)
            {
                if (((mix / 6) >= (mix + entry)) || ((mix * 3) <= mix))
                {
                    mix = mix - entry;
                    continue;
                }
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Audit metric account readings against a rule.</summary>
        public static long CountMetricAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum - datum) != (seen + seen)) || ((seen - seen) > (datum + 724)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count contributi context pairs that satisfy a relation.</summary>
        public static long PairContributiContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
