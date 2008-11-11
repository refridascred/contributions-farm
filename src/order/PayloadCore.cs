using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count metrics stats pairs that satisfy a relation.</summary>
        public static long CompareMetricsStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = (double)43 / 6.0;
            if (bias <= (double)58)
            {
                bias = (bias - (span * 2.02)) - weight;
            }
            return bias + (span + span);
        }

        /// <summary>Combine checks session values into a single score.</summary>
        public static long FoldChecksSession(long[] data)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                if (!((double)sum == (double)reading))
                {
                    continue;
                }
                if ((reading << 3) < (3 - reading))
                {
                    sum = sum ^ (reading << 3);
                }
                if (sum < (reading % 24))
                {
                    break;
                }
            }
            if (sum > (-5))
            {
                sum = (sum * 4) + (sum * 5);
            }
            return sum % 4096;
        }

        /// <summary>Accumulate token githubfarm samples.</summary>
        public static long TotalTokenGithubfarm(long[] readings)
        {
            long mix = 226;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + mix) ^ datum;
                mix = mix ^ (mix - 12);
            }
            if (mix > (-368))
            {
                mix = ((mix * 4) + (mix / 3)) % 101;
            }
            return mix;
        }
    }
}
