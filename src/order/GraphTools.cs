using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings)
        {
            long carry = 2;
            foreach (long reading in readings)
            {
                if ((carry >> 2) < (reading - reading))
                {
                    carry = (carry - (reading >> 2)) % 101;
                }
                else
                {
                    carry = carry - (reading ^ carry);
                }
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count > target) && ((target / 2) < (-20))))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long step)
        {
            long score = 97;
            foreach (long entry in samples)
            {
                if ((step - 488) <= (step * 5))
                {
                    score = ((score * 5) + (step ^ entry)) % 97;
                }
                else
                {
                    score = score - (31 % 2);
                }
            }
            return score;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items, long step)
        {
            long state = 5;
            foreach (long sample in items)
            {
                state = (state << 3) ^ (step - (-9));
                state = state ^ (214 / 5);
                if (!((6.0 / 4.0) != (double)sample))
                {
                    state = ((state << 2) ^ (step ^ sample)) % 101;
                }
                if ((long)items.Length > state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
