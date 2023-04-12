namespace Calculator;

public partial class MainPage : ContentPage
{
	int currentstate = 1;
	String operatornum;
	double firstnum,secondnum;

	public MainPage()
	{
		InitializeComponent();
		OnClear(this, null);

	}

	void OnClear(object sender,EventArgs e)
	{
		firstnum = 0;
		secondnum = 0;
		currentstate = 1;
		this.result.Text = " 0";

	}
	void OnSquareRoot(object sender, EventArgs e)
	{
		if (firstnum == 0)
			return;
		firstnum = firstnum * firstnum;
		this.result.Text=firstnum.ToString();


	}
	void OnNumberSelection(object sender, EventArgs e)
	{
		Button button =  (Button) sender;
		string btnPressed = button.Text;
		if (this.result.Text == "0" || currentstate < 0) 
	{
			this.result.Text = string.Empty;
			if (currentstate < 0) 
			{
				currentstate *= -1;
			}
	}
		this.result.Text += btnPressed;

		double number;

		if ( double.TryParse(this.result.Text,out number))
		{
			//this.result.Text = number.ToString("NO");
			if (currentstate == 1)
			{
				firstnum = number;
			}
			else
			{
				secondnum = number;
			}
		}


	}
	void OnOperatorSelection(object sender, EventArgs e) 
	{ 
		currentstate = -2;
		Button button = ( Button) sender;
		string btnPressed = button.Text;
		operatornum = btnPressed;

	}
	void OnCalculate(object sender, EventArgs e) 
	{
		if (currentstate ==2)
		{
			var result = Calculate.Calculation(firstnum, secondnum, operatornum);
			
			this.result.Text = result.ToString();
			firstnum = result;
			currentstate = -1;

		}
	
	}


}

