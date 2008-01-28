using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long ClassifyCommitsReport(long limit, long limit2)
        {
            long span = limit + limit2;
            if (((limit2 ^ 98) >= (9 & 7)) && (limit2 <= (span - limit)))
            {
                return 4;
            }
            else
            {
                if ((limit2 <= (9 / 4)) || ((84 & 15) < span))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 2) ^ (result + (long)i);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
