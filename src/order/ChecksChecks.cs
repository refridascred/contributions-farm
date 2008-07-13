using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long target, long step)
        {
            long cur = target + step;
            if (5.56 > (double)target)
            {
                return 7;
            }
            else
            {
                if (target >= (cur + 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
