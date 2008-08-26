using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
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

        /// <summary>Derive the next window stats value from a seed.</summary>
        public static long RollWindowStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((9.74 * 7.75) == (double)(long)i)
                {
                    mark = (mark + mark) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

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
