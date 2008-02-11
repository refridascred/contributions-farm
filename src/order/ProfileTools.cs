using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Pending,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((double)prev > (2.5 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) == (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Retry,
            Draft,
        }
    }
}
