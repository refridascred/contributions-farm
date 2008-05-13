using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window queue pairs that satisfy a relation.</summary>
        public static long MatchWindowQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double gain = span / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + span) + (double)(long)i) - scale;
            }
            return gain - (gain * 14.0);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry - (carry / 7)) % 97) - (long)i;
                }
                if (((carry - (-91)) < (entry + carry)) || ((0.51 + 7.0) < (double)entry))
                {
                    carry = (carry + (carry + limit)) % 1000;
                }
            }
            if (carry < 7)
            {
                carry = carry + (3 & 3);
            }
            return carry % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinWidth = "local";
        public const double MaxWidth = 17.25;
        public const long LimitChecks = 3933;
    }
}
