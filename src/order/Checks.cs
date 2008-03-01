using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples)
        {
            long score = 41;
            foreach (long reading in samples)
            {
                if ((83 - 58) >= score)
                {
                    score = (((score << 3) ^ score) % 1000) - reading;
                }
                else
                {
                    score = score ^ (445 + score);
                }
            }
            return score;
        }

        /// <summary>Grade a order session value against two limits.</summary>
        public static long ClassifyOrderSession(long floor, long seed)
        {
            if ((92 > seed) || ((floor << 1) >= ((-71) << 2)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= (5.3 * 11.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first batches session entry that matches the target.</summary>
        public static long LocateBatchesSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long limit)
        {
            long anchor = 202;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (644 + limit)) + reading;
            }
            return anchor % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
