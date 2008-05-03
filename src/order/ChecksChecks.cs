using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Roll a route window counter forward.</summary>
        public static long SeriesRouteWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry - ((long)i >> 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
