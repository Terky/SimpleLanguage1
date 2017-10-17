// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-32TFS7K
// DateTime: 17.10.2017 18:05:38
// UserName: wowit
// Input file <SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using ProgramTree;

namespace SimpleParser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,CYCLE=5,ASSIGN=6,
    SEMICOLON=7,PLUS=8,MINUS=9,LEFT_BRACKET=10,RIGHT_BRACKET=11,DIV=12,
    MULT=13,VAR=14,COLON=15,INUM=16,RNUM=17,ID=18};

public struct ValueType
{ 
			public double dVal; 
			public int iVal; 
			public string sVal; 
			public Node nVal;
			public ExprNode eVal;
			public StatementNode stVal;
			public BlockNode blVal;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from SimpleYacc.y
// This defenition goes to class GPPGParser, which is a parser, that generated by gppg system
    public BlockNode root; // Syntax tree root 
	public SimpleLang.SymbolTable top;
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[24];
  private static State[] states = new State[42];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "term", "factor", "assign", "statement", "cycle", "stlist", 
      "block", "progr", "$accept", "decl", "Anon@1", };

  static Parser() {
    states[0] = new State(new int[]{3,4},new int[]{-10,1,-9,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(-20,new int[]{-13,5});
    states[5] = new State(new int[]{18,26,3,4,5,32,14,36},new int[]{-8,6,-6,41,-5,10,-2,11,-9,30,-7,31,-12,35});
    states[6] = new State(new int[]{4,7,7,8});
    states[7] = new State(-21);
    states[8] = new State(new int[]{18,26,3,4,5,32,14,36},new int[]{-6,9,-5,10,-2,11,-9,30,-7,31,-12,35});
    states[9] = new State(-4);
    states[10] = new State(-5);
    states[11] = new State(new int[]{6,12});
    states[12] = new State(new int[]{10,18,18,26,16,27},new int[]{-1,13,-3,29,-4,28,-2,25});
    states[13] = new State(new int[]{8,14,9,21,4,-10,7,-10});
    states[14] = new State(new int[]{10,18,18,26,16,27},new int[]{-3,15,-4,28,-2,25});
    states[15] = new State(new int[]{13,16,12,23,8,-11,9,-11,4,-11,7,-11,11,-11,18,-11,3,-11,5,-11,14,-11});
    states[16] = new State(new int[]{10,18,18,26,16,27},new int[]{-4,17,-2,25});
    states[17] = new State(-14);
    states[18] = new State(new int[]{10,18,18,26,16,27},new int[]{-1,19,-3,29,-4,28,-2,25});
    states[19] = new State(new int[]{11,20,8,14,9,21});
    states[20] = new State(-17);
    states[21] = new State(new int[]{10,18,18,26,16,27},new int[]{-3,22,-4,28,-2,25});
    states[22] = new State(new int[]{13,16,12,23,8,-12,9,-12,4,-12,7,-12,11,-12,18,-12,3,-12,5,-12,14,-12});
    states[23] = new State(new int[]{10,18,18,26,16,27},new int[]{-4,24,-2,25});
    states[24] = new State(-15);
    states[25] = new State(-18);
    states[26] = new State(-9);
    states[27] = new State(-19);
    states[28] = new State(-16);
    states[29] = new State(new int[]{13,16,12,23,8,-13,9,-13,4,-13,7,-13,11,-13,18,-13,3,-13,5,-13,14,-13});
    states[30] = new State(-6);
    states[31] = new State(-7);
    states[32] = new State(new int[]{10,18,18,26,16,27},new int[]{-1,33,-3,29,-4,28,-2,25});
    states[33] = new State(new int[]{8,14,9,21,18,26,3,4,5,32,14,36},new int[]{-6,34,-5,10,-2,11,-9,30,-7,31,-12,35});
    states[34] = new State(-22);
    states[35] = new State(-8);
    states[36] = new State(new int[]{18,37});
    states[37] = new State(new int[]{15,38});
    states[38] = new State(new int[]{18,39});
    states[39] = new State(new int[]{7,40});
    states[40] = new State(-23);
    states[41] = new State(-3);

    rules[1] = new Rule(-11, new int[]{-10,2});
    rules[2] = new Rule(-10, new int[]{-9});
    rules[3] = new Rule(-8, new int[]{-6});
    rules[4] = new Rule(-8, new int[]{-8,7,-6});
    rules[5] = new Rule(-6, new int[]{-5});
    rules[6] = new Rule(-6, new int[]{-9});
    rules[7] = new Rule(-6, new int[]{-7});
    rules[8] = new Rule(-6, new int[]{-12});
    rules[9] = new Rule(-2, new int[]{18});
    rules[10] = new Rule(-5, new int[]{-2,6,-1});
    rules[11] = new Rule(-1, new int[]{-1,8,-3});
    rules[12] = new Rule(-1, new int[]{-1,9,-3});
    rules[13] = new Rule(-1, new int[]{-3});
    rules[14] = new Rule(-3, new int[]{-3,13,-4});
    rules[15] = new Rule(-3, new int[]{-3,12,-4});
    rules[16] = new Rule(-3, new int[]{-4});
    rules[17] = new Rule(-4, new int[]{10,-1,11});
    rules[18] = new Rule(-4, new int[]{-2});
    rules[19] = new Rule(-4, new int[]{16});
    rules[20] = new Rule(-13, new int[]{});
    rules[21] = new Rule(-9, new int[]{3,-13,-8,4});
    rules[22] = new Rule(-7, new int[]{5,-1,-6});
    rules[23] = new Rule(-12, new int[]{14,18,15,18,7});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> block
{ top = null;
				  root = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 3: // stlist -> statement
{ 
				CurrentSemanticValue.blVal = new BlockNode(ValueStack[ValueStack.Depth-1].stVal); 
			}
        break;
      case 4: // stlist -> stlist, SEMICOLON, statement
{ 
				ValueStack[ValueStack.Depth-3].blVal.Add(ValueStack[ValueStack.Depth-1].stVal); 
				CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-3].blVal; 
			}
        break;
      case 5: // statement -> assign
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 6: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 7: // statement -> cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 8: // statement -> decl
{}
        break;
      case 9: // ident -> ID
{ CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal);
			   SimpleLang.VarSymbol s = top.Get(ValueStack[ValueStack.Depth-1].sVal);
			   if (s!=null) {
			     CurrentSemanticValue.eVal.Value = s;
			   } else {
			   //error
			   }
			     
			 }
        break;
      case 10: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); 
							  SimpleLang.VarSymbol s = top.Get(ValueStack[ValueStack.Depth-3].eVal);
							  if (s!=null) {
								ValueStack[ValueStack.Depth-3].eVal.Value = ValueStack[ValueStack.Depth-1].eVal.eval();
							  } else {
							  //error
							  }
							}
        break;
      case 11: // expr -> expr, PLUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Plus); }
        break;
      case 12: // expr -> expr, MINUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Minus); }
        break;
      case 13: // expr -> term
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 14: // term -> term, MULT, factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Mult); }
        break;
      case 15: // term -> term, DIV, factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Div); }
        break;
      case 16: // term -> factor
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 17: // factor -> LEFT_BRACKET, expr, RIGHT_BRACKET
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 18: // factor -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 19: // factor -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 20: // Anon@1 -> /* empty */
{ SimpleParser.ParserHelper.saved = top;
					top = new SimpleLang.SymbolTable(top);
				  }
        break;
      case 21: // block -> BEGIN, Anon@1, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-3];
					  top = SimpleParser.ParserHelper.saved; }
        break;
      case 22: // cycle -> CYCLE, expr, statement
{ CurrentSemanticValue.stVal = new CycleNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 23: // decl -> VAR, ID, COLON, ID, SEMICOLON
{   SimpleLang.VarSymbol s = new SimpleLang.VarSymbol();
										SimpleLang.TypeSymbol t = (top.Get(ValueStack[ValueStack.Depth-2].sVal)) as SimpleLang.TypeSymbol;
										s.Type = t.Value;
										top.Put(ValueStack[ValueStack.Depth-4].sVal, s); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }


}
}
