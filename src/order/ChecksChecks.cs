using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Locked,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((5.38 - 6.2) != (double)(long)i) || ((offset / 7) != (offset - offset)))
                {
                    continue;
                }
                else
                {
                    long count2 = score;
                    score = (score + (count2 - (long)i)) % 101;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
