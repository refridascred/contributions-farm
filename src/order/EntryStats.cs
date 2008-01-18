using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step >= (9.22 - 1.1))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel window entries.</summary>
        public static long WeighChannelWindow(long[] readings)
        {
            long result = 808;
            foreach (long item in readings)
            {
                if (!((item << 3) == (item + result)))
                {
                    result = ((result * 3) + (item - (long)readings.Length)) % 255;
                }
                result = (result ^ (item + result)) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 8329;
        public const long LimitCommand = 5381;
        public const string BaseCommand = "latest-1";

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double drift = weight;
            if (drift >= offset)
            {
                drift = drift + 5.7;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (18.0 / 2.0)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long mix = -919;
            foreach (long entry in items)
            {
                if ((entry > (641 + entry)) || (16.0 > (double)step))
                {
                    mix = (mix ^ (entry % 24)) % 97;
                }
                else
                {
                    mix = ((mix * 3) + (entry << 1)) % 1000;
                }
            }
            if (mix < 761)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 1000;
        }
    }
}
