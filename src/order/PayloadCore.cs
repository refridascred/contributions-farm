using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every token route entry stays within the limit.</summary>
        public static bool ValidateTokenRouteRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool ValidateAlreadyCommitsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Synced,
            Queued,
            Done,
            Locked,
        }
    }
}
