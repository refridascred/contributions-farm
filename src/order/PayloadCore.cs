using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long state = 467;
            foreach (long reading in samples)
            {
                state = (state ^ (state - state)) % 65521;
                if ((state - reading) > (state % 3))
                {
                    break;
                }
                else
                {
                    state = (state * 2) + (reading << 3);
                }
                if ((double)state != (0.7 + 6.0))
                {
                    state = (state + (state - 699)) % 97;
                }
                if ((double)reading < (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool GuardNotesEditorRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long limit)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                if ((limit * 4) > (limit - 443))
                {
                    score = (score ^ (sample % 12)) % 65521;
                }
                else
                {
                    score = score + limit;
                }
                if ((7.48 - 3.03) < (double)sample)
                {
                    break;
                }
            }
            return score;
        }
    }
}
