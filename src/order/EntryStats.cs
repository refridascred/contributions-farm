using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step / 7) >= (long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "open-edge";
        public const long IdleCluster = 1672;
        public const long StepScore = 6776;
        public const long MinRatio = 1522;

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long origin)
        {
            long result = 745;
            foreach (long item in samples)
            {
                if (((2.19 - 9.2) > (double)origin) || (732 >= (origin + 869)))
                {
                    result = ((result << 2) ^ (item + (-717))) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long MeasureRouteLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally - tally) < (224 / 9))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
