using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of route batch readings.</summary>
        public static long MatchRouteBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = (result * 2) + item;
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (origin - result)) + (long)i;
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((96 * 5) == (88 ^ result))
                {
                    result = ((result * 3) + (result + 466)) % 1000;
                }
            }
            if (result < 7)
            {
                result = ((result << 2) ^ (origin % 16)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Validate channel queue readings against a bound.</summary>
        public static bool CheckChannelQueueBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 8) == ((long)levels.Length + (-4)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
