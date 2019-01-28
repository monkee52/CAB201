using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using Low_Level_Objects_Library;

namespace Games {
    /// <summary>
    /// Provides easy access to the coin and card images, 
    /// via the GetCoinImage, GetCardImage and GetBackOfCardImage methods.
    /// 
    /// For your assignment, it is not important to understand all the finer details 
    /// of all the methods in this class.
    /// 
    /// Do not confuse this class with the Microsoft-supplied class, Image, which has a similar name.
    /// 
    /// Modified (with permission) by Ayden Hull to use application resources
    /// </summary>
    public static class Images {
        /// <summary>
        /// Returns a head or tails coin image.
        /// </summary>
        /// <param name="isHeads"> boolean</param>
        /// <returns>the heads image if parameter isHeads is true; otherwise returns tails image</returns>
        public static Bitmap GetCoinImage(bool isHeads) {
            if (isHeads) {
                return Properties.Resources.Heads150;
            } else {
                return Properties.Resources.Tails150;
            }
        }

        /// <summary>
        /// Returns the image for a given Card.
        /// </summary>
        /// <param name="card"></param>
        /// <returns>the image for the Card specified by the parameter.</returns>
        public static Bitmap GetCardImage(Card card) {
            Suit suit = card.GetSuit();
            FaceValue faceValue = card.GetFaceValue();

            string name = string.Format("{0}{1}", suit.ToString().TrimEnd('s'), faceValue);

            return (Bitmap)Properties.Resources.ResourceManager.GetObject(name);
        }

        /// <summary>
        /// Returns the image for the back (i.e. reverse side) of each card.
        /// </summary>
        /// <returns>the image for the back of each card.</returns>
        public static Bitmap GetBackOfCardImage() {
            return Properties.Resources.CardBack_Red;
        }

        public static Bitmap GetDieImage(int faceValue) {
            return (Bitmap)Properties.Resources.ResourceManager.GetObject("Face_" + faceValue.ToString());
        }
    }
}
