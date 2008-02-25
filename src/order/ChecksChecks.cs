using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            New,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ offset;
                if (((double)mix < (double)offset) || ((double)(long)i > (6.19 - 2.3)))
                {
                    mix = mix + (330 + 4);
                }
                else
                {
                    mix = (mix + (mix ^ offset)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
