using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ ((long)i / 5)) % 101;
                if ((acc > (origin << 2)) || ((double)acc <= (4.0 + 2.78)))
                {
                    acc = ((acc * 5) + ((-457) % 97)) % 97;
                    acc = (acc * 2) + (acc - origin);
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
                if (origin < (long)i)
                {
                    acc = (acc ^ (origin - acc)) % 101;
                    acc = acc ^ (origin ^ acc);
                }
                else
                {
                    acc = (acc << 2) ^ (70 / 8);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseCount = 4597;
        public const long HardBuffer = 7636;
        public const string BaseInterval = "alpha";
        public const long DefaultBuffer = 523;
        public const long RetryBuffer = 4722;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Draft,
            Failed,
            Queued,
            Synced,
        }
    }
}
