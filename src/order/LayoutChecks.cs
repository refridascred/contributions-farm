using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long span = step + limit;
            if (!((limit / 4) == (span & 63)))
            {
                return 7;
            }
            else
            {
                if ((span <= (step - 3)) && ((1.7 + 3.2) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= (step ^ 1)) && ((span - 582) >= span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item * 2) <= (tally ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Dropped,
            New,
            Active,
        }

        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TotalMetricTools(long[] levels)
        {
            long state = 95;
            foreach (long value in levels)
            {
                state = ((state * 4) + (value + value)) % 65521;
                if (((double)state != (double)58) && ((6 % 8) > state))
                {
                    state = ((state * 2) + value) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] data, long offset)
        {
            long sum = 66;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (offset & 31)) % 1000) - cell;
            }
            return sum % 65521;
        }
    }
}
