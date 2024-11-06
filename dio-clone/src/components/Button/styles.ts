import styled, { css } from "styled-components";
import { IButtonStyled } from "./types";

export const ButtonContainer = styled.button<IButtonStyled>`
    background: #565656;
    border-radius: 22px;
    position: relative;

    color: #FFF;
    padding: 2px 12px;
    min-width: 128px;
    witdh: 100%;

    ${({variant}) => variant !== "primary" && css`
        min-width: 167px;
        height: 32px;

        background: #E41050;

        &:hover {
            opacity: 0.6;
            cursor: pointer;
        }

        &::after {
            content: '';
            position: absolute;
            padding: 2px 12px;
            border: 1px solid #E41050;
            top: -5px;
            left: -6px;
            width: calc(100% - 10px);
            height: calc(100% - -5px);
            border-radius: 22px;
        }
    `}
`