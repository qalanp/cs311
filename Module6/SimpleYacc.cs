// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  LAPTOP-1ISHOG01
// DateTime: 10.11.2018 20:22:03
// UserName: qalanp
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
    SEMICOLON=7,WHILE=8,DO=9,REPEAT=10,UNTIL=11,FOR=12,
    TO=13,WRITE=14,IF=15,THEN=16,ELSE=17,LEFT_BRACKET=18,
    RIGHT_BRACKET=19,VAR=20,COMMA=21,PLUS=22,MINUS=23,MULT=24,
    DIV=25,INUM=26,RNUM=27,ID=28};

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
// ��� ���������� ����������� � ����� GPPGParser, �������������� ����� ������, ������������ �������� gppg
    public BlockNode root; // �������� ���� ��������������� ������ 
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
    private bool InDefSect = false;
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[37];
  private static State[] states = new State[74];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "T", "F", "assign", "statement", "cycle", "while", "repeat", 
      "for", "write", "if", "var", "varlist", "stlist", "block", "progr", "$accept", 
      "Anon@1", };

  static Parser() {
    states[0] = new State(new int[]{3,4},new int[]{-17,1,-16,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-15,5,-6,44,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[5] = new State(new int[]{4,6,7,7});
    states[6] = new State(-16);
    states[7] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-6,8,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[8] = new State(-4);
    states[9] = new State(-5);
    states[10] = new State(new int[]{6,11});
    states[11] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,12,-3,28,-4,27,-2,17});
    states[12] = new State(new int[]{22,13,23,23,4,-15,7,-15,11,-15,17,-15});
    states[13] = new State(new int[]{28,18,26,19,18,20},new int[]{-3,14,-4,27,-2,17});
    states[14] = new State(new int[]{24,15,25,25,22,-28,23,-28,4,-28,7,-28,11,-28,17,-28,19,-28,28,-28,3,-28,5,-28,8,-28,10,-28,12,-28,14,-28,15,-28,20,-28,9,-28,13,-28,16,-28});
    states[15] = new State(new int[]{28,18,26,19,18,20},new int[]{-4,16,-2,17});
    states[16] = new State(-31);
    states[17] = new State(-34);
    states[18] = new State(-14);
    states[19] = new State(-35);
    states[20] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,21,-3,28,-4,27,-2,17});
    states[21] = new State(new int[]{19,22,22,13,23,23});
    states[22] = new State(-36);
    states[23] = new State(new int[]{28,18,26,19,18,20},new int[]{-3,24,-4,27,-2,17});
    states[24] = new State(new int[]{24,15,25,25,22,-29,23,-29,4,-29,7,-29,11,-29,17,-29,19,-29,28,-29,3,-29,5,-29,8,-29,10,-29,12,-29,14,-29,15,-29,20,-29,9,-29,13,-29,16,-29});
    states[25] = new State(new int[]{28,18,26,19,18,20},new int[]{-4,26,-2,17});
    states[26] = new State(-32);
    states[27] = new State(-33);
    states[28] = new State(new int[]{24,15,25,25,22,-30,23,-30,4,-30,7,-30,11,-30,17,-30,19,-30,28,-30,3,-30,5,-30,8,-30,10,-30,12,-30,14,-30,15,-30,20,-30,9,-30,13,-30,16,-30});
    states[29] = new State(-6);
    states[30] = new State(-7);
    states[31] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,32,-3,28,-4,27,-2,17});
    states[32] = new State(new int[]{22,13,23,23,28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-6,33,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[33] = new State(-17);
    states[34] = new State(-8);
    states[35] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,36,-3,28,-4,27,-2,17});
    states[36] = new State(new int[]{9,37,22,13,23,23});
    states[37] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-6,38,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[38] = new State(-18);
    states[39] = new State(-9);
    states[40] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-15,41,-6,44,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[41] = new State(new int[]{11,42,7,7});
    states[42] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,43,-3,28,-4,27,-2,17});
    states[43] = new State(new int[]{22,13,23,23,4,-19,7,-19,11,-19,17,-19});
    states[44] = new State(-3);
    states[45] = new State(-10);
    states[46] = new State(new int[]{28,18},new int[]{-2,47});
    states[47] = new State(new int[]{6,48});
    states[48] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,49,-3,28,-4,27,-2,17});
    states[49] = new State(new int[]{13,50,22,13,23,23});
    states[50] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,51,-3,28,-4,27,-2,17});
    states[51] = new State(new int[]{9,52,22,13,23,23});
    states[52] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-6,53,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[53] = new State(-20);
    states[54] = new State(-11);
    states[55] = new State(new int[]{18,56});
    states[56] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,57,-3,28,-4,27,-2,17});
    states[57] = new State(new int[]{19,58,22,13,23,23});
    states[58] = new State(-21);
    states[59] = new State(-12);
    states[60] = new State(new int[]{28,18,26,19,18,20},new int[]{-1,61,-3,28,-4,27,-2,17});
    states[61] = new State(new int[]{16,62,22,13,23,23});
    states[62] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-6,63,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[63] = new State(new int[]{17,64,4,-23,7,-23,11,-23});
    states[64] = new State(new int[]{28,18,3,4,5,31,8,35,10,40,12,46,14,55,15,60,20,67},new int[]{-6,65,-5,9,-2,10,-16,29,-7,30,-8,34,-9,39,-10,45,-11,54,-12,59,-13,66});
    states[65] = new State(-22);
    states[66] = new State(-13);
    states[67] = new State(-26,new int[]{-19,68});
    states[68] = new State(new int[]{28,18},new int[]{-14,69,-2,73});
    states[69] = new State(new int[]{7,70,21,71});
    states[70] = new State(-27);
    states[71] = new State(new int[]{28,18},new int[]{-2,72});
    states[72] = new State(-25);
    states[73] = new State(-24);

    rules[1] = new Rule(-18, new int[]{-17,2});
    rules[2] = new Rule(-17, new int[]{-16});
    rules[3] = new Rule(-15, new int[]{-6});
    rules[4] = new Rule(-15, new int[]{-15,7,-6});
    rules[5] = new Rule(-6, new int[]{-5});
    rules[6] = new Rule(-6, new int[]{-16});
    rules[7] = new Rule(-6, new int[]{-7});
    rules[8] = new Rule(-6, new int[]{-8});
    rules[9] = new Rule(-6, new int[]{-9});
    rules[10] = new Rule(-6, new int[]{-10});
    rules[11] = new Rule(-6, new int[]{-11});
    rules[12] = new Rule(-6, new int[]{-12});
    rules[13] = new Rule(-6, new int[]{-13});
    rules[14] = new Rule(-2, new int[]{28});
    rules[15] = new Rule(-5, new int[]{-2,6,-1});
    rules[16] = new Rule(-16, new int[]{3,-15,4});
    rules[17] = new Rule(-7, new int[]{5,-1,-6});
    rules[18] = new Rule(-8, new int[]{8,-1,9,-6});
    rules[19] = new Rule(-9, new int[]{10,-15,11,-1});
    rules[20] = new Rule(-10, new int[]{12,-2,6,-1,13,-1,9,-6});
    rules[21] = new Rule(-11, new int[]{14,18,-1,19});
    rules[22] = new Rule(-12, new int[]{15,-1,16,-6,17,-6});
    rules[23] = new Rule(-12, new int[]{15,-1,16,-6});
    rules[24] = new Rule(-14, new int[]{-2});
    rules[25] = new Rule(-14, new int[]{-14,21,-2});
    rules[26] = new Rule(-19, new int[]{});
    rules[27] = new Rule(-13, new int[]{20,-19,-14,7});
    rules[28] = new Rule(-1, new int[]{-1,22,-3});
    rules[29] = new Rule(-1, new int[]{-1,23,-3});
    rules[30] = new Rule(-1, new int[]{-3});
    rules[31] = new Rule(-3, new int[]{-3,24,-4});
    rules[32] = new Rule(-3, new int[]{-3,25,-4});
    rules[33] = new Rule(-3, new int[]{-4});
    rules[34] = new Rule(-4, new int[]{-2});
    rules[35] = new Rule(-4, new int[]{26});
    rules[36] = new Rule(-4, new int[]{18,-1,19});
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
{ root = ValueStack[ValueStack.Depth-1].blVal; }
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
      case 8: // statement -> while
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 9: // statement -> repeat
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 10: // statement -> for
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 11: // statement -> write
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 12: // statement -> if
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 13: // statement -> var
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 14: // ident -> ID
{
			if (!InDefSect)
				if (SymbolTable.vars.ContainsKey(ValueStack[ValueStack.Depth-1].sVal))
					throw new Exception("("+LocationStack[LocationStack.Depth-1].StartLine+","+LocationStack[LocationStack.Depth-1].StartColumn+"): ���������� " + ValueStack[ValueStack.Depth-1].sVal + " ��� ����������");
			CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); 
		}
        break;
      case 15: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 16: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 17: // cycle -> CYCLE, expr, statement
{ CurrentSemanticValue.stVal = new CycleNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 18: // while -> WHILE, expr, DO, statement
{ CurrentSemanticValue.stVal = new WhileNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 19: // repeat -> REPEAT, stlist, UNTIL, expr
{ CurrentSemanticValue.stVal = new RepeatNode(ValueStack[ValueStack.Depth-3].blVal, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 20: // for -> FOR, ident, ASSIGN, expr, TO, expr, DO, statement
{ CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-7].eVal as IdNode, ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 21: // write -> WRITE, LEFT_BRACKET, expr, RIGHT_BRACKET
{ CurrentSemanticValue.stVal = new WriteNode(ValueStack[ValueStack.Depth-2].eVal); }
        break;
      case 22: // if -> IF, expr, THEN, statement, ELSE, statement
{ CurrentSemanticValue.stVal = new IfNode(ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].stVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 23: // if -> IF, expr, THEN, statement
{ CurrentSemanticValue.stVal = new IfNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 24: // varlist -> ident
{ CurrentSemanticValue.stVal = new VarDefNode(ValueStack[ValueStack.Depth-1].eVal as IdNode); }
        break;
      case 25: // varlist -> varlist, COMMA, ident
{ 
				(ValueStack[ValueStack.Depth-3].stVal as VarDefNode).Add(ValueStack[ValueStack.Depth-1].eVal as IdNode); 
				CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-3].stVal;
			}
        break;
      case 26: // Anon@1 -> /* empty */
{ InDefSect = true; }
        break;
      case 27: // var -> VAR, Anon@1, varlist, SEMICOLON
{ 
                foreach(var v in (ValueStack[ValueStack.Depth-2].stVal as VarDefNode).Ids)
                    SymbolTable.NewVarDef(v.Name, type.tint);
                InDefSect = false;
            }
        break;
      case 28: // expr -> expr, PLUS, T
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, '+'); }
        break;
      case 29: // expr -> expr, MINUS, T
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, '-'); }
        break;
      case 30: // expr -> T
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 31: // T -> T, MULT, F
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, '*'); }
        break;
      case 32: // T -> T, DIV, F
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, '/'); }
        break;
      case 33: // T -> F
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 34: // F -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 35: // F -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 36: // F -> LEFT_BRACKET, expr, RIGHT_BRACKET
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
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