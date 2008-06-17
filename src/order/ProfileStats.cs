using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((offset - cell) >= (offset - tally)) || !((cell / 2) >= ((long)levels.Length / 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double drift = (scale * 4.0) / 8.0;
            if (drift < drift)
            {
                drift = (drift + scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
