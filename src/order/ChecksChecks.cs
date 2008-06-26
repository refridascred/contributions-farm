using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of filter channel readings.</summary>
        public static long DigestFilterChannel(long[] data, long step)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                mix = mix + (mix >> 4);
                if ((double)entry < 5.53)
                {
                    break;
                }
            }
            if (mix < 59)
            {
                mix = (mix - (mix - step)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long CountEditorFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((76 ^ count) > count)
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
