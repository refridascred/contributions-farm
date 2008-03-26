using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + matches) >= (matches + matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long step)
        {
            if (step <= (step - limit))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (8.2 - 5.79))
                {
                    return 0;
                }
                else
                {
                    if (step <= ((-1) % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
