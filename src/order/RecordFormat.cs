using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long state = 658;
            foreach (long reading in series)
            {
                state = state ^ (reading + state);
                if ((reading ^ reading) >= (state + state))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = ((state << 2) ^ (state + 0)) % 65521;
                }
            }
            if (state < 916)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long step)
        {
            if ((double)limit <= (17.0 - 3.6))
            {
                return 4;
            }
            else
            {
                if (((10.0 / 9.0) == (double)limit) || (limit >= 20))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > 8.1)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter checks readings.</summary>
        public static long DigestCounterChecks(long[] data, long target)
        {
            long anchor = 59;
            foreach (long entry in data)
            {
                if ((double)target <= 6.51)
                {
                    anchor = (anchor + entry) % 65521;
                }
                if ((target >= (target & 63)) || ((entry * 4) > (entry % 7)))
                {
                    break;
                }
            }
            if (anchor < 345)
            {
                anchor = anchor + 0;
            }
            return anchor;
        }
    }
}
