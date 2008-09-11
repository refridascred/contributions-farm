using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (score / 9)) % 4096;
                if ((score / 2) == (score + (long)i))
                {
                    score = score ^ (origin * 2);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value * 2) > (value >> 2)) || ((value & 3) != (630 + target)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Idle,
            Stale,
            Pending,
            New,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
