using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of cluster support readings.</summary>
        public static long PairClusterSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already order sample.</summary>
        public static long LocateAlreadyOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account record entries.</summary>
        public static long TotalAccountRecord(long[] series, long step)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if ((mix + datum) > (mix ^ datum))
                {
                    mix = (((mix * 5) + (datum >> 5)) % 65521) + step;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long floor)
        {
            long state = 40;
            foreach (long entry in series)
            {
                state = (((state * 2) + (state * 5)) % 101) + floor;
                state = (state - (entry % 100)) % 101;
            }
            if (state < 53)
            {
                state = (state - state) % 101;
            }
            return state % 97;
        }
    }
}
