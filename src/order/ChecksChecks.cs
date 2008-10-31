using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long carry = 72;
            foreach (long value in data)
            {
                if (((carry + value) >= ((-104) - carry)) || ((value << 1) != (7 + 4)))
                {
                    carry = (carry - (value + value)) % 65521;
                }
            }
            if (carry > 62)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Accumulate context cache samples.</summary>
        public static long TallyContextCache(long[] levels, long step)
        {
            long total = 689;
            foreach (long value in levels)
            {
                total = ((total * 3) + (396 / 3)) - value;
                if (!((step * 3) >= (89 << 2)))
                {
                    total = (total * 2) + (long)levels.Length;
                }
                else
                {
                    total = (total - (301 - step)) % 97;
                }
                total = total ^ step;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
