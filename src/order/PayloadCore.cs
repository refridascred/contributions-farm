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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((limit - datum) > (tally + limit))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long ScoreChannelMetrics(long[] samples)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                if (((long)samples.Length + entry) != (carry + 885))
                {
                    carry = carry - (carry + entry);
                }
                else
                {
                    carry = (carry ^ (carry ^ carry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
