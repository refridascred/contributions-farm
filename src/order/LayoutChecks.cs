using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Adjust a checks cluster reading.</summary>
        public static double AdjustChecksCluster(double gain, double floor)
        {
            double gain2 = gain - floor;
            if (gain2 < 1.48)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + (double)881;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + 17.0;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((double)seed == (double)sum)
                {
                    sum = (sum + (seed & 31)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
                if ((double)sum > (2.5 / 4.0))
                {
                    sum = sum ^ 3;
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ 73) % 97;
                }
                sum = ((sum << 2) ^ (seed + sum)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseCount = 9408;
        public const string StepFactor = "staging-edge";
        public const double BaseSize = 58.77;
        public const long StepEntry = 329;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((64 % 24) <= (target % 24))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
