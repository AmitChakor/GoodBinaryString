using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoodBinaryString
{
    public partial class _Default : Page
    {
        string s = "";
		StringBuilder sb = new StringBuilder();
		protected void Page_Load(object sender, EventArgs e)
        {			
		}

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
			s = txtBinaryString.Text;			
			Label8.Text = CompareString(s) ? "Its a good Binary string" : "Its not a good Binary string";			
		}

		// Method returns 1 when string is valid 
		// else returns 0 
		public bool checkString(String s)
		{
			
			int len = s.Length;

			// Find first occurrence of 1 in s[] 
			int first = 0;
			for (int i = 0; i < len; i++)
			{
				if (s[i] == '1')
				{
					first = i;
					break;
				}
			}

			// Find last occurrence of 1 in s[] 
			int last = 0;
			for (int i = len - 1; i >= 0; i--)
			{
				if (s[i] == '1')
				{
					last = i;
					break;
				}
			}

			// Check if there is any 0 in range 
			for (int i = first; i <= last; i++)
				if (s[i] == '0')
					return false;

			return true;
		}


		// Method returns 1 when string is valid 
		// else returns 0
		// conditions : checks if number of 1's are equal to number of 0's
		protected bool CompareString(String s)
		{
			clearLabels();
			int len = s.Length;
			
			// get the no of 1's 
			int count1s = 0;
			for (int i = 0; i < len; i++)
			{
				if (s[i] == '1')
				{
					count1s++;
				}
			}
			Label1.Text = "No. of 1's in the string are : " + count1s;
		
			// get the no of 0's 
			int count0s = 0;
			for (int j = len - 1; j >= 0; j--)
			{
				if (s[j] == '0')
				{
					count0s++;
				}
			}
			Label2.Text = "No. of 0's in the string are : " + count0s;		

			// Check if for every prefix No. of 1's are not less then No. of 0's 
			int counter_0s = 0;
			int counter_1s = 0;
			bool condition2Passed = true;			
			for (int k = 0; k < len; k++)
			{
				if (s[k] == '0')
				{
					counter_0s++;
				}
				else if (s[k] == '1')
				{
					counter_1s++;
				}

				// checking if No. of 1's are less than No. of 0's 
				if (counter_1s < counter_0s)
				{
					condition2Passed = false;

				}
			}

			if (count1s == count0s)
			{
				Label3.Text= "No. of 1's are equal to No. of 0's in the given string : " + s;				
			}
			else
			{
				Label4.Text = "No. of 1's are not equal to No. of 0's in the given string : " + s ;				
			}
			if (condition2Passed == true)
			{
				Label5.Text = "The condition that for every prefix, No. of 1's are more then No. of 0's in the given string " + s + " passes.";				
			}
			else
			{
				Label6.Text = "The condition that for every prefix, No. of 1's should be more then No. of 0's in the given string " + s + " fails.";				
			}

			//check if number of 1s are equal to number of 0s and condition2  is passed
			if (count1s == count0s && condition2Passed == true)
			{
				Label7.Text = "No. of 1's are equal to No. of 0's and for every prefix No. of 1's are more then No. of 0's in the given string : " + s;				
				return true;
			}

			return false;
		}

		protected void clearLabels()
        {			
			Label1.Text = "";
			Label2.Text = "";
			Label3.Text = "";
			Label4.Text = "";
			Label5.Text = "";
			Label6.Text = "";
			Label7.Text = "";
			Label8.Text = "";
		}

	}
}