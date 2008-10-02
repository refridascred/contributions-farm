using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry checks entries.</summary>
        public static long TallyEntryChecks(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if ((mix & 31) < cell)
                {
                    mix = ((mix * 4) + (711 - cell)) % 65521;
                }
                if ((mix ^ cell) <= cell)
                {
                    mix = ((mix << 2) ^ (cell - cell)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long CombineProfileChecks(long[] values)
        {
            long acc = 503;
            foreach (long sample in values)
            {
                acc = (acc * 5) + sample;
            }
            return acc;
        }

        /// <summary>Check that every stream notes entry stays within the limit.</summary>
        public static bool CheckStreamNotesBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long limit)
        {
            if ((7 / 7) < limit)
            {
                return 1;
            }
            else
            {
                if (((limit - 3) > (limit - target)) && (limit <= (427 + target)))
                {
                    return 5;
                }
                else
                {
                    if ((601 % 24) < (target ^ limit))
                    {
                        return 4;
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
