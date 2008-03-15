using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already counter readings against a bound.</summary>
        public static bool VerifyAlreadyCounterBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long TallyNotesTools(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score - target) % 255;
                score = score - (cell % 10);
                if ((target << 3) > (79 % 100))
                {
                    score = (score ^ target) % 65521;
                }
                else
                {
                    score = score + ((-238) - target);
                }
            }
            if (score < 558)
            {
                score = score + (target >> 1);
            }
            return score % 65521;
        }
    }
}
